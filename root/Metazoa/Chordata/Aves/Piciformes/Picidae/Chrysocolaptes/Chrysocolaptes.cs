using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Chrysocolaptes;

/// <summary>
/// Abstract class for Chrysocolaptes (genus).
/// NCBI TaxId: 315364
/// </summary>
public abstract class Chrysocolaptes : Picidae, IChrysocolaptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chrysocolaptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315364;

    /// <inheritdoc />
    public virtual string GenusName => "Chrysocolaptes";

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
