using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Meliphagidae.Acanthagenys;

/// <summary>
/// Abstract class for Acanthagenys (genus).
/// NCBI TaxId: 266412
/// </summary>
public abstract class Acanthagenys : Meliphagidae, IAcanthagenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthagenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 266412;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthagenys";

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
