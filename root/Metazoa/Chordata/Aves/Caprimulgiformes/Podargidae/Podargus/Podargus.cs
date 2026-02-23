using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Podargidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Podargidae.Podargus;

/// <summary>
/// Abstract class for Podargus (genus).
/// NCBI TaxId: 8904
/// </summary>
public abstract class Podargus : Podargidae, IPodargus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podargus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8904;

    /// <inheritdoc />
    public virtual string GenusName => "Podargus";

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
