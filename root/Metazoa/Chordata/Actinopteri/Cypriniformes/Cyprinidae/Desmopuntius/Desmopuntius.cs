using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Desmopuntius;

/// <summary>
/// Abstract class for Desmopuntius (genus).
/// NCBI TaxId: 1606646
/// </summary>
public abstract class Desmopuntius : Cyprinidae, IDesmopuntius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Desmopuntius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1606646;

    /// <inheritdoc />
    public virtual string GenusName => "Desmopuntius";

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
