using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Stomiidae.Chirostomias;

/// <summary>
/// Abstract class for Chirostomias (genus).
/// NCBI TaxId: 700628
/// </summary>
public abstract class Chirostomias : Stomiidae, IChirostomias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chirostomias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 700628;

    /// <inheritdoc />
    public virtual string GenusName => "Chirostomias";

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
