using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Campephagidae.Cyanograucalus;

/// <summary>
/// Abstract class for Cyanograucalus (genus).
/// NCBI TaxId: 1743255
/// </summary>
public abstract class Cyanograucalus : Campephagidae, ICyanograucalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyanograucalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1743255;

    /// <inheritdoc />
    public virtual string GenusName => "Cyanograucalus";

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
