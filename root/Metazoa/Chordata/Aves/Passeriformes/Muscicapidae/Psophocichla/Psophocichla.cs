using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Psophocichla;

/// <summary>
/// Abstract class for Psophocichla (genus).
/// NCBI TaxId: 311371
/// </summary>
public abstract class Psophocichla : Muscicapidae, IPsophocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psophocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311371;

    /// <inheritdoc />
    public virtual string GenusName => "Psophocichla";

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
