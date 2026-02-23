using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.Schizolecis;

/// <summary>
/// Abstract class for Schizolecis (genus).
/// NCBI TaxId: 510796
/// </summary>
public abstract class Schizolecis : Loricariidae, ISchizolecis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Schizolecis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 510796;

    /// <inheritdoc />
    public virtual string GenusName => "Schizolecis";

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
