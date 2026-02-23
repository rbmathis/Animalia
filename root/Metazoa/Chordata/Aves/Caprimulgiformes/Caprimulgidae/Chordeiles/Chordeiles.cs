using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Chordeiles;

/// <summary>
/// Abstract class for Chordeiles (genus).
/// NCBI TaxId: 48288
/// </summary>
public abstract class Chordeiles : Caprimulgidae, IChordeiles
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chordeiles";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48288;

    /// <inheritdoc />
    public virtual string GenusName => "Chordeiles";

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
