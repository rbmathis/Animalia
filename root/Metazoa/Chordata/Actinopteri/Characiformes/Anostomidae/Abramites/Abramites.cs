using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Abramites;

/// <summary>
/// Abstract class for Abramites (genus).
/// NCBI TaxId: 42617
/// </summary>
public abstract class Abramites : Anostomidae, IAbramites
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abramites";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42617;

    /// <inheritdoc />
    public virtual string GenusName => "Abramites";

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
