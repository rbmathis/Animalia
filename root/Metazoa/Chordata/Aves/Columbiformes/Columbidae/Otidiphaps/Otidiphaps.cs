using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Otidiphaps;

/// <summary>
/// Abstract class for Otidiphaps (genus).
/// NCBI TaxId: 187129
/// </summary>
public abstract class Otidiphaps : Columbidae, IOtidiphaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otidiphaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187129;

    /// <inheritdoc />
    public virtual string GenusName => "Otidiphaps";

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
