using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Alauda;

/// <summary>
/// Abstract class for Alauda (genus).
/// NCBI TaxId: 88111
/// </summary>
public abstract class Alauda : Alaudidae, IAlauda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alauda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 88111;

    /// <inheritdoc />
    public virtual string GenusName => "Alauda";

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
