using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Lagocephalus;

/// <summary>
/// Abstract class for Lagocephalus (genus).
/// NCBI TaxId: 204813
/// </summary>
public abstract class Lagocephalus : Tetraodontidae, ILagocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lagocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 204813;

    /// <inheritdoc />
    public virtual string GenusName => "Lagocephalus";

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
