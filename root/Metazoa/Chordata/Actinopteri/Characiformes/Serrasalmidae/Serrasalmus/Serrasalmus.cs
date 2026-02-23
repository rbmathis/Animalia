using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Serrasalmus;

/// <summary>
/// Abstract class for Serrasalmus (genus).
/// NCBI TaxId: 42515
/// </summary>
public abstract class Serrasalmus : Serrasalmidae, ISerrasalmus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Serrasalmus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42515;

    /// <inheritdoc />
    public virtual string GenusName => "Serrasalmus";

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
