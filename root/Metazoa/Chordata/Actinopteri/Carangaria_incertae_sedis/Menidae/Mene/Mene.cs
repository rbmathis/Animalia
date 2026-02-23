using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Menidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangaria_incertae_sedis.Menidae.Mene;

/// <summary>
/// Abstract class for Mene (genus).
/// NCBI TaxId: 206144
/// </summary>
public abstract class Mene : Menidae, IMene
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mene";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 206144;

    /// <inheritdoc />
    public virtual string GenusName => "Mene";

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
