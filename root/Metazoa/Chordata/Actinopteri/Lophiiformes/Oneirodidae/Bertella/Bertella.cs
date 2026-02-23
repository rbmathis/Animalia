using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Oneirodidae.Bertella;

/// <summary>
/// Abstract class for Bertella (genus).
/// NCBI TaxId: 242939
/// </summary>
public abstract class Bertella : Oneirodidae, IBertella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bertella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 242939;

    /// <inheritdoc />
    public virtual string GenusName => "Bertella";

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
