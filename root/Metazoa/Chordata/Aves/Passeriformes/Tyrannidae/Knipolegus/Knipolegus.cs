using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Knipolegus;

/// <summary>
/// Abstract class for Knipolegus (genus).
/// NCBI TaxId: 377286
/// </summary>
public abstract class Knipolegus : Tyrannidae, IKnipolegus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Knipolegus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 377286;

    /// <inheritdoc />
    public virtual string GenusName => "Knipolegus";

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
