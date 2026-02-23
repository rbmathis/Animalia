using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Alaudidae.Eremalauda;

/// <summary>
/// Abstract class for Eremalauda (genus).
/// NCBI TaxId: 215318
/// </summary>
public abstract class Eremalauda : Alaudidae, IEremalauda
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremalauda";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215318;

    /// <inheritdoc />
    public virtual string GenusName => "Eremalauda";

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
