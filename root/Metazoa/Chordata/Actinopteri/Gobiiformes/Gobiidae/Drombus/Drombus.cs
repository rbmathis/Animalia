using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Drombus;

/// <summary>
/// Abstract class for Drombus (genus).
/// NCBI TaxId: 1285435
/// </summary>
public abstract class Drombus : Gobiidae, IDrombus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drombus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1285435;

    /// <inheritdoc />
    public virtual string GenusName => "Drombus";

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
