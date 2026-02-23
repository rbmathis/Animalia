using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Gymnophaps;

/// <summary>
/// Abstract class for Gymnophaps (genus).
/// NCBI TaxId: 262120
/// </summary>
public abstract class Gymnophaps : Columbidae, IGymnophaps
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnophaps";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 262120;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnophaps";

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
