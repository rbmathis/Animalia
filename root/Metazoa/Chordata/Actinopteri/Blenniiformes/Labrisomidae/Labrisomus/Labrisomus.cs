using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Labrisomus;

/// <summary>
/// Abstract class for Labrisomus (genus).
/// NCBI TaxId: 57815
/// </summary>
public abstract class Labrisomus : Labrisomidae, ILabrisomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labrisomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57815;

    /// <inheritdoc />
    public virtual string GenusName => "Labrisomus";

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
