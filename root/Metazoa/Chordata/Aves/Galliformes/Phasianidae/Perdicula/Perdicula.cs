using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Perdicula;

/// <summary>
/// Abstract class for Perdicula (genus).
/// NCBI TaxId: 249171
/// </summary>
public abstract class Perdicula : Phasianidae, IPerdicula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Perdicula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249171;

    /// <inheritdoc />
    public virtual string GenusName => "Perdicula";

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
