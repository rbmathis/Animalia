using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Podargidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Podargidae.Rigidipenna;

/// <summary>
/// Abstract class for Rigidipenna (genus).
/// NCBI TaxId: 424214
/// </summary>
public abstract class Rigidipenna : Podargidae, IRigidipenna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rigidipenna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 424214;

    /// <inheritdoc />
    public virtual string GenusName => "Rigidipenna";

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
