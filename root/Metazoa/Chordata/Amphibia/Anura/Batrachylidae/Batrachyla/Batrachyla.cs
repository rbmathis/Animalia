using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Batrachylidae.Batrachyla;

/// <summary>
/// Abstract class for Batrachyla (genus).
/// NCBI TaxId: 215151
/// </summary>
public abstract class Batrachyla : Batrachylidae, IBatrachyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Batrachyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215151;

    /// <inheritdoc />
    public virtual string GenusName => "Batrachyla";

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
