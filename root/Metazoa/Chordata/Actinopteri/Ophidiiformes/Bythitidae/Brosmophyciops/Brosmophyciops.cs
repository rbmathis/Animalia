using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Bythitidae.Brosmophyciops;

/// <summary>
/// Abstract class for Brosmophyciops (genus).
/// NCBI TaxId: 1156450
/// </summary>
public abstract class Brosmophyciops : Bythitidae, IBrosmophyciops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brosmophyciops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1156450;

    /// <inheritdoc />
    public virtual string GenusName => "Brosmophyciops";

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
