using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Lophotis;

/// <summary>
/// Abstract class for Lophotis (genus).
/// NCBI TaxId: 172688
/// </summary>
public abstract class Lophotis : Otididae, ILophotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lophotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 172688;

    /// <inheritdoc />
    public virtual string GenusName => "Lophotis";

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
