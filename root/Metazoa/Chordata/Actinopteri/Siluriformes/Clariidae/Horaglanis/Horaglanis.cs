using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Horaglanis;

/// <summary>
/// Abstract class for Horaglanis (genus).
/// NCBI TaxId: 1193623
/// </summary>
public abstract class Horaglanis : Clariidae, IHoraglanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Horaglanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1193623;

    /// <inheritdoc />
    public virtual string GenusName => "Horaglanis";

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
