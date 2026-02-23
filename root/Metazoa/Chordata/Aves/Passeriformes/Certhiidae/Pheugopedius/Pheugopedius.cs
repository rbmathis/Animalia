using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Pheugopedius;

/// <summary>
/// Abstract class for Pheugopedius (genus).
/// NCBI TaxId: 1167646
/// </summary>
public abstract class Pheugopedius : Certhiidae, IPheugopedius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pheugopedius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1167646;

    /// <inheritdoc />
    public virtual string GenusName => "Pheugopedius";

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
