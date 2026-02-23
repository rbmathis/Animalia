using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Sayornis;

/// <summary>
/// Abstract class for Sayornis (genus).
/// NCBI TaxId: 56314
/// </summary>
public abstract class Sayornis : Tyrannidae, ISayornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sayornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56314;

    /// <inheritdoc />
    public virtual string GenusName => "Sayornis";

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
