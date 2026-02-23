using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Pseudochromidae.Pictichromis;

/// <summary>
/// Abstract class for Pictichromis (genus).
/// NCBI TaxId: 692220
/// </summary>
public abstract class Pictichromis : Pseudochromidae, IPictichromis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pictichromis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 692220;

    /// <inheritdoc />
    public virtual string GenusName => "Pictichromis";

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
