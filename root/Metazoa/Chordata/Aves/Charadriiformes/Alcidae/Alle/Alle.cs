using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Alle;

/// <summary>
/// Abstract class for Alle (genus).
/// NCBI TaxId: 28690
/// </summary>
public abstract class Alle : Alcidae, IAlle
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alle";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28690;

    /// <inheritdoc />
    public virtual string GenusName => "Alle";

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
