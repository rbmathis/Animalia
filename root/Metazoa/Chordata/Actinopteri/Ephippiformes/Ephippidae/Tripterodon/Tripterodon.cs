using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ephippiformes.Ephippidae.Tripterodon;

/// <summary>
/// Abstract class for Tripterodon (genus).
/// NCBI TaxId: 1003989
/// </summary>
public abstract class Tripterodon : Ephippidae, ITripterodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tripterodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003989;

    /// <inheritdoc />
    public virtual string GenusName => "Tripterodon";

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
