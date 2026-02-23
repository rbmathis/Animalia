using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Mastacembelidae.Sinobdella;

/// <summary>
/// Abstract class for Sinobdella (genus).
/// NCBI TaxId: 1620287
/// </summary>
public abstract class Sinobdella : Mastacembelidae, ISinobdella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinobdella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1620287;

    /// <inheritdoc />
    public virtual string GenusName => "Sinobdella";

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
