using AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Picidae.Geocolaptes;

/// <summary>
/// Abstract class for Geocolaptes (genus).
/// NCBI TaxId: 315368
/// </summary>
public abstract class Geocolaptes : Picidae, IGeocolaptes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geocolaptes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 315368;

    /// <inheritdoc />
    public virtual string GenusName => "Geocolaptes";

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
