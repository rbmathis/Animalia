using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Muscipipra;

/// <summary>
/// Abstract class for Muscipipra (genus).
/// NCBI TaxId: 2338509
/// </summary>
public abstract class Muscipipra : Tyrannidae, IMuscipipra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muscipipra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2338509;

    /// <inheritdoc />
    public virtual string GenusName => "Muscipipra";

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
