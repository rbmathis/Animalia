using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Uranoscopiformes.Uranoscopidae.Uranoscopus;

/// <summary>
/// Abstract class for Uranoscopus (genus).
/// NCBI TaxId: 70847
/// </summary>
public abstract class Uranoscopus : Uranoscopidae, IUranoscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uranoscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 70847;

    /// <inheritdoc />
    public virtual string GenusName => "Uranoscopus";

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
