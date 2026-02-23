using AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Thinocoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Ciconiiformes.Thinocoridae.Thinocorus;

/// <summary>
/// Abstract class for Thinocorus (genus).
/// NCBI TaxId: 161741
/// </summary>
public abstract class Thinocorus : Thinocoridae, IThinocorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thinocorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161741;

    /// <inheritdoc />
    public virtual string GenusName => "Thinocorus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
