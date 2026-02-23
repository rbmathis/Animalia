using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Alca;

/// <summary>
/// Abstract class for Alca (genus).
/// NCBI TaxId: 28688
/// </summary>
public abstract class Alca : Alcidae, IAlca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28688;

    /// <inheritdoc />
    public virtual string GenusName => "Alca";

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
