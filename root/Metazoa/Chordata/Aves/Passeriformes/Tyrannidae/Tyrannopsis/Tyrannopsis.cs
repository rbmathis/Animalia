using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tyrannopsis;

/// <summary>
/// Abstract class for Tyrannopsis (genus).
/// NCBI TaxId: 649819
/// </summary>
public abstract class Tyrannopsis : Tyrannidae, ITyrannopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tyrannopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 649819;

    /// <inheritdoc />
    public virtual string GenusName => "Tyrannopsis";

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
