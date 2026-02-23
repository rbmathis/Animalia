using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osmeriformes.Salangidae.Mallotus;

/// <summary>
/// Abstract class for Mallotus (genus).
/// NCBI TaxId: 30959
/// </summary>
public abstract class Mallotus : Salangidae, IMallotus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mallotus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30959;

    /// <inheritdoc />
    public virtual string GenusName => "Mallotus";

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
