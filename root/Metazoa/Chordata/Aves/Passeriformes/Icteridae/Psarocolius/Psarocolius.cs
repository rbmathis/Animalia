using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Psarocolius;

/// <summary>
/// Abstract class for Psarocolius (genus).
/// NCBI TaxId: 84844
/// </summary>
public abstract class Psarocolius : Icteridae, IPsarocolius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Psarocolius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84844;

    /// <inheritdoc />
    public virtual string GenusName => "Psarocolius";

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
