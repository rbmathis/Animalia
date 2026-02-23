using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Dunckerocampus;

/// <summary>
/// Abstract class for Dunckerocampus (genus).
/// NCBI TaxId: 587050
/// </summary>
public abstract class Dunckerocampus : Syngnathidae, IDunckerocampus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dunckerocampus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587050;

    /// <inheritdoc />
    public virtual string GenusName => "Dunckerocampus";

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
