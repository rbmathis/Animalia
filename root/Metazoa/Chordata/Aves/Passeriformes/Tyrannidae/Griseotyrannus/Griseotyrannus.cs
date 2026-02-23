using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Griseotyrannus;

/// <summary>
/// Abstract class for Griseotyrannus (genus).
/// NCBI TaxId: 478642
/// </summary>
public abstract class Griseotyrannus : Tyrannidae, IGriseotyrannus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Griseotyrannus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 478642;

    /// <inheritdoc />
    public virtual string GenusName => "Griseotyrannus";

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
