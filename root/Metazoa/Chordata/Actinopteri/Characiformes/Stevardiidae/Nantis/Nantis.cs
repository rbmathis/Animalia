using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Nantis;

/// <summary>
/// Abstract class for Nantis (genus).
/// NCBI TaxId: 1463126
/// </summary>
public abstract class Nantis : Stevardiidae, INantis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nantis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1463126;

    /// <inheritdoc />
    public virtual string GenusName => "Nantis";

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
