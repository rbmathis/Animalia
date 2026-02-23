using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Eulacestoma;

/// <summary>
/// Abstract class for Eulacestoma (genus).
/// NCBI TaxId: 461238
/// </summary>
public abstract class Eulacestoma : Passeriformes, IEulacestoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eulacestoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461238;

    /// <inheritdoc />
    public virtual string GenusName => "Eulacestoma";

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
