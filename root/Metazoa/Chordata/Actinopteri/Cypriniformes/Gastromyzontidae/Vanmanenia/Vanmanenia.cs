using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Vanmanenia;

/// <summary>
/// Abstract class for Vanmanenia (genus).
/// NCBI TaxId: 241473
/// </summary>
public abstract class Vanmanenia : Gastromyzontidae, IVanmanenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vanmanenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241473;

    /// <inheritdoc />
    public virtual string GenusName => "Vanmanenia";

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
