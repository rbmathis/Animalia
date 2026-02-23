using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Muraenidae.Scuticaria;

/// <summary>
/// Abstract class for Scuticaria (genus).
/// NCBI TaxId: 210591
/// </summary>
public abstract class Scuticaria : Muraenidae, IScuticaria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scuticaria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210591;

    /// <inheritdoc />
    public virtual string GenusName => "Scuticaria";

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
