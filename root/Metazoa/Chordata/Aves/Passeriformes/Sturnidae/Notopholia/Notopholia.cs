using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sturnidae.Notopholia;

/// <summary>
/// Abstract class for Notopholia (genus).
/// NCBI TaxId: 1851201
/// </summary>
public abstract class Notopholia : Sturnidae, INotopholia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notopholia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1851201;

    /// <inheritdoc />
    public virtual string GenusName => "Notopholia";

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
