using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Oriolia;

/// <summary>
/// Abstract class for Oriolia (genus).
/// NCBI TaxId: 125273
/// </summary>
public abstract class Oriolia : Vangidae, IOriolia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oriolia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125273;

    /// <inheritdoc />
    public virtual string GenusName => "Oriolia";

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
