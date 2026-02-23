using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Eretmobrycon;

/// <summary>
/// Abstract class for Eretmobrycon (genus).
/// NCBI TaxId: 190782
/// </summary>
public abstract class Eretmobrycon : Stevardiidae, IEretmobrycon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eretmobrycon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190782;

    /// <inheritdoc />
    public virtual string GenusName => "Eretmobrycon";

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
