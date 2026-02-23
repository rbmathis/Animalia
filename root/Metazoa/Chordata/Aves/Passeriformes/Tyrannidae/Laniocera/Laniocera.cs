using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Laniocera;

/// <summary>
/// Abstract class for Laniocera (genus).
/// NCBI TaxId: 265626
/// </summary>
public abstract class Laniocera : Tyrannidae, ILaniocera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laniocera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 265626;

    /// <inheritdoc />
    public virtual string GenusName => "Laniocera";

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
