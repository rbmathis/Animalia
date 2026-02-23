using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Acropomatidae.Doederleinia;

/// <summary>
/// Abstract class for Doederleinia (genus).
/// NCBI TaxId: 223794
/// </summary>
public abstract class Doederleinia : Acropomatidae, IDoederleinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Doederleinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 223794;

    /// <inheritdoc />
    public virtual string GenusName => "Doederleinia";

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
