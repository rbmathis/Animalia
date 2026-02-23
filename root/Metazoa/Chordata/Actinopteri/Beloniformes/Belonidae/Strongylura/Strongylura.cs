using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Strongylura;

/// <summary>
/// Abstract class for Strongylura (genus).
/// NCBI TaxId: 94936
/// </summary>
public abstract class Strongylura : Belonidae, IStrongylura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Strongylura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94936;

    /// <inheritdoc />
    public virtual string GenusName => "Strongylura";

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
