using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gerreiformes.Gerreidae.Gerres;

/// <summary>
/// Abstract class for Gerres (genus).
/// NCBI TaxId: 274464
/// </summary>
public abstract class Gerres : Gerreidae, IGerres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gerres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274464;

    /// <inheritdoc />
    public virtual string GenusName => "Gerres";

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
