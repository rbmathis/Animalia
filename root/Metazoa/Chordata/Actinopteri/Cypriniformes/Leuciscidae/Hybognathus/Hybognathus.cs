using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Hybognathus;

/// <summary>
/// Abstract class for Hybognathus (genus).
/// NCBI TaxId: 86919
/// </summary>
public abstract class Hybognathus : Leuciscidae, IHybognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hybognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 86919;

    /// <inheritdoc />
    public virtual string GenusName => "Hybognathus";

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
