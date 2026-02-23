using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Urodynamis;

/// <summary>
/// Abstract class for Urodynamis (genus).
/// NCBI TaxId: 2497755
/// </summary>
public abstract class Urodynamis : Cuculidae, IUrodynamis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urodynamis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2497755;

    /// <inheritdoc />
    public virtual string GenusName => "Urodynamis";

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
