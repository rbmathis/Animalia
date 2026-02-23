using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Nettastomatidae.Facciolella;

/// <summary>
/// Abstract class for Facciolella (genus).
/// NCBI TaxId: 182428
/// </summary>
public abstract class Facciolella : Nettastomatidae, IFacciolella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Facciolella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182428;

    /// <inheritdoc />
    public virtual string GenusName => "Facciolella";

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
