using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Podoces;

/// <summary>
/// Abstract class for Podoces (genus).
/// NCBI TaxId: 257845
/// </summary>
public abstract class Podoces : Corvidae, IPodoces
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podoces";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 257845;

    /// <inheritdoc />
    public virtual string GenusName => "Podoces";

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
