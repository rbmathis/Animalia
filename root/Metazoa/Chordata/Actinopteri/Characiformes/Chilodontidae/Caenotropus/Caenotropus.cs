using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chilodontidae.Caenotropus;

/// <summary>
/// Abstract class for Caenotropus (genus).
/// NCBI TaxId: 490541
/// </summary>
public abstract class Caenotropus : Chilodontidae, ICaenotropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caenotropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490541;

    /// <inheritdoc />
    public virtual string GenusName => "Caenotropus";

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
