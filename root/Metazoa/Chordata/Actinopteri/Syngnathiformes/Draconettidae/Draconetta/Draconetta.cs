using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Draconettidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Draconettidae.Draconetta;

/// <summary>
/// Abstract class for Draconetta (genus).
/// NCBI TaxId: 215390
/// </summary>
public abstract class Draconetta : Draconettidae, IDraconetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Draconetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215390;

    /// <inheritdoc />
    public virtual string GenusName => "Draconetta";

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
