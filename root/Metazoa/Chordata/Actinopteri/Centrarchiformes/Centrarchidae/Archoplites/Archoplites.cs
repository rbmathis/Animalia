using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Archoplites;

/// <summary>
/// Abstract class for Archoplites (genus).
/// NCBI TaxId: 201700
/// </summary>
public abstract class Archoplites : Centrarchidae, IArchoplites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archoplites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 201700;

    /// <inheritdoc />
    public virtual string GenusName => "Archoplites";

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
