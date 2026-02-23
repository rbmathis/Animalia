using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Zanclidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acanthuriformes.Zanclidae.Zanclus;

/// <summary>
/// Abstract class for Zanclus (genus).
/// NCBI TaxId: 75043
/// </summary>
public abstract class Zanclus : Zanclidae, IZanclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zanclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 75043;

    /// <inheritdoc />
    public virtual string GenusName => "Zanclus";

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
