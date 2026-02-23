using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocorax;

/// <summary>
/// Abstract class for Cyanocorax (genus).
/// NCBI TaxId: 54578
/// </summary>
public abstract class Cyanocorax : Corvidae, ICyanocorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanocorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54578;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanocorax";

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
